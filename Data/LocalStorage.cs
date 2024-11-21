using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ContractMonthlyClaimSystem.Models;

namespace ContractMonthlyClaimSystem.Data
{
    public static class LocalStorage
    {
        private static List<Claim> claims = new();
        private static readonly string FilePath = "claims.json";

        static LocalStorage()
        {
            if (File.Exists(FilePath))
            {
                var jsonData = File.ReadAllText(FilePath);
                claims = JsonSerializer.Deserialize<List<Claim>>(jsonData) ?? new List<Claim>();
            }
        }

        public static List<Claim> GetClaims() => claims;

        public static void AddClaim(Claim claim)
        {
            claims.Add(claim);
            SaveChanges();
        }

        public static void UpdateClaim(Claim updatedClaim)
        {
            var claim = claims.FirstOrDefault(c => c.Id == updatedClaim.Id);
            if (claim != null)
            {
                claim.Status = updatedClaim.Status;
            }
            SaveChanges();
        }

        private static void SaveChanges()
        {
            var jsonData = JsonSerializer.Serialize(claims);
            File.WriteAllText(FilePath, jsonData);
        }
    }
}
