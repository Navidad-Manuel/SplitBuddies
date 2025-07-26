// Archivo: Services/BalanceService.cs
using SplitBuddies.App.Models;
using System.Collections.Generic;
using System.Linq;

namespace SplitBuddies.App.Services
{
    /// <summary>
    /// Servicio estático para realizar todos los cálculos de saldos.
    /// Cumple con el Principio de Responsabilidad Única.
    /// </summary>
    public static class BalanceService
    {
        /// <summary>
        /// Calcula el balance general de un usuario.
        /// Un valor positivo significa que le deben dinero.
        /// Un valor negativo significa que debe dinero.
        /// </summary>
        public static decimal GetUserBalance(int userId, IEnumerable<Expense> allExpenses)
        {
            // 1. Sumar todo lo que el usuario ha pagado por otros.
            decimal totalPaid = allExpenses
                .Where(e => e.PayerId == userId)
                .Sum(e => e.Amount);

            // 2. Sumar todo lo que el usuario debe de los gastos en los que participó.
            decimal totalOwed = allExpenses
                // Filtramos gastos donde el usuario es un participante.
                .Where(e => e.ParticipantIds != null && e.ParticipantIds.Contains(userId))
                // Para cada gasto, calculamos la parte que le corresponde.
                .Sum(e => {
                    // MEJORA: Comprobación para evitar división por cero si la lista de participantes está vacía.
                    if (e.ParticipantIds.Any())
                    {
                        return e.Amount / e.ParticipantIds.Count;
                    }
                    return 0; // Si no hay participantes, no debe nada de este gasto.
                });

            // 3. El balance final es la diferencia.
            return totalPaid - totalOwed;
        }
    }
}