
using SplitBuddies.App.Models; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitBuddies.App.Services
{
    public static class BalanceService
    {
        public static decimal GetUserBalance(int userId, IEnumerable<Expense> allExpenses)
        {
            decimal totalPaid = allExpenses
                .Where(e => e.PayerId == userId) 
                .Sum(e => e.Amount);
            decimal totalOwed = allExpenses
                .Where(e => e.ParticipantIds != null && e.ParticipantIds.Contains(userId))
                .Sum(e => {
                    if (e.ParticipantIds.Any())
                    {
                        return e.Amount / e.ParticipantIds.Count;
                    }
                    return 0;
                });
            return totalPaid - totalOwed;
        }


        public static List<string> CalculateGroupBalances(Group group, List<User> allUsers, List<Expense> allExpenses)
        {
            var balances = new Dictionary<int, decimal>();
            var results = new List<string>();
            var groupExpenses = allExpenses.Where(e => e.GroupId == group.Id).ToList(); 
            if (!groupExpenses.Any())
            {
                results.Add("No hay gastos registrados en este grupo.");
                return results;
            }
            foreach (var memberId in group.MemberIds)
            {
                decimal paidInGroup = groupExpenses.Where(e => e.PayerId == memberId).Sum(e => e.Amount);
                decimal owedInGroup = groupExpenses.Where(e => e.ParticipantIds.Contains(memberId))
                                                   .Sum(e => e.Amount / e.ParticipantIds.Count);
                balances[memberId] = paidInGroup - owedInGroup;
            }
            var debtors = balances.Where(b => b.Value < 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            var creditors = balances.Where(b => b.Value > 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var debtor in debtors.ToList()) 
            {
                int debtorId = debtor.Key;
                decimal amountOwed = -debtor.Value;
                while (amountOwed > 0.01m && creditors.Any())
                {
                    var creditor = creditors.First();
                    int creditorId = creditor.Key;
                    decimal amountToReceive = creditor.Value;
                    decimal payment = Math.Min(amountOwed, amountToReceive);

                    string debtorName = allUsers.FirstOrDefault(u => u.Id == debtorId)?.Name ?? "Usuario Desconocido";
                    string creditorName = allUsers.FirstOrDefault(u => u.Id == creditorId)?.Name ?? "Usuario Desconocido";
                    results.Add($"{debtorName} debe a {creditorName}: {payment:C}");

                    amountOwed -= payment;
                    creditors[creditorId] -= payment;
                    if (creditors[creditorId] < 0.01m)
                    {
                        creditors.Remove(creditorId);
                    }
                }
            }

            if (!results.Any())
            {
                results.Add("Todos los saldos en el grupo están a cero.");
            }
            return results;
        }
    }
}