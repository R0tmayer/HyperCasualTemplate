﻿namespace Core.Upgrades
{
    public class StatPresenter
    {
        private UpgradesConfig _upgradesUpgradesConfig;
        private StatLevelSaver _statLevelSaver;

        public void Construct(UpgradesConfig upgradesUpgradesConfig, StatLevelSaver statLevelSaver)
        {
            _statLevelSaver = statLevelSaver;
            _upgradesUpgradesConfig = upgradesUpgradesConfig;
        }

        public int PowerValue => _upgradesUpgradesConfig.PowerList[_statLevelSaver.PowerLevel].Value;
        public int SpeedValue => _upgradesUpgradesConfig.SpeedList[_statLevelSaver.SpeedLevel].Value;
        public int ArmorValue => _upgradesUpgradesConfig.ArmorList[_statLevelSaver.ArmorLevel].Value;        
        
        public int PowerCost => _upgradesUpgradesConfig.PowerList[_statLevelSaver.PowerLevel].Value;
        public int SpeedCost => _upgradesUpgradesConfig.SpeedList[_statLevelSaver.SpeedLevel].Value;
        public int ArmorCost => _upgradesUpgradesConfig.ArmorList[_statLevelSaver.ArmorLevel].Value;
    }
}