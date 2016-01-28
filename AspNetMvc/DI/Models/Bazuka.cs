using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class Bazuka : IWeapon
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void Kill()
        {
            logger.Info("BIG BADABUM!");
        }
    }
}
