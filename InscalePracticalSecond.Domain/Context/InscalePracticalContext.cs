using InscalePracticalSecond.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InscalePracticalSecond.Domain.Context
{
    public class InscalePracticalContext : DbContext
    {
        public InscalePracticalContext()
        {

        }

        public DbSet<PostData> PostDatas { get; set; }
    }
}
