using Questao2._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2._1.Application.Interfaces
{
    public interface IApplication
    {
        Task<Matches> Get(string team, int year);
    }
}
