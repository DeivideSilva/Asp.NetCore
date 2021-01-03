using Lanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanches.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche>Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int lancheId);
    }
}
