using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using RankingApp.Data.Models;

namespace RankingApp.Data.Services
{
    public class RankingService
    {
        ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create
        public Task<GameResult> AddGameResult(GameResult gameResult)
        {
            _context.GameResults.Add(gameResult);
            // 메모리에 갱신 - ORM의 장점 : DB에 따로 접근하지 않아도 함수 하나로 자동으로 가능
            _context.SaveChanges();

            return Task.FromResult(gameResult);
        }

        // Read
        public Task<List<GameResult>> GetGameResultAsync()
        {
            List<GameResult> results = _context.GameResults
                .OrderByDescending(item => item.Score)
                .ToList();

            return Task.FromResult(results);
        }

        // Update

        // Delete
    }
}
