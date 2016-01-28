using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class Sword : IWeapon
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void Kill()
        {
            logger.Info("Chuk-chuck");
        }
    }
}
