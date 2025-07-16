using SplitBuddies.App.Models;
using System.Collections.Generic;
using System.Linq;

namespace SplitBuddies.App.Services
{
    public static class BalanceService
    {
        /// <summary>
        /// Calcula el balance de un solo usuario basado en todos los gastos.
        /// Un balance positivo significa que le deben dinero; negativo significa que debe dinero.
        /// </summary>
        /// <param name="userId">El ID del usuario a calcular.</param>
        /// <param name="allExpenses">La lista completa de todos los gastos.</param>
        /// <returns>El balance total del usuario en formato decimal.</returns>
        public static decimal GetUserBalance(int userId, List<Expense> allExpenses)
        {
            // 1. Calcular  el dinero que el usuario ha pagado por otros.
            // Esta parte ya era eficiente y estaba bien.
            decimal totalPaid = allExpenses
                .Where(e => e.PayerId == userId)
                .Sum(e => e.Amount);

            // 2. Calcular la deuda total del usuario por los gastos en los que participó.
            // --- ESTA ES LA CORRECCIÓN PARA S3267 ---
            // Reemplazamos el bucle 'foreach' con una única expresión LINQ que hace lo mismo.
            // Es más seguro y más conciso.
            decimal totalOwed = allExpenses
                // Filtramos gastos donde el usuario es participante Y nos aseguramos de que haya participantes para evitar división por cero.
                .Where(e => e.ParticipantIds.Any() && e.ParticipantIds.Contains(userId))
                // Sumamos la parte que le corresponde de cada gasto.
                .Sum(e => e.Amount / e.ParticipantIds.Count);

            // 3. El balance final es lo que pagó menos lo que debe.
            return totalPaid - totalOwed;
        }
    }
}