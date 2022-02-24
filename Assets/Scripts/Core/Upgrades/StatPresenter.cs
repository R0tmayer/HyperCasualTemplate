namespace Core.Upgrades
{
    public class StatPresenter
    {
        private readonly UpgradesConfig _upgradesUpgradesConfig;
        private readonly StatLevelSaver _statLevelSaver;

        public StatPresenter(UpgradesConfig upgradesUpgradesConfig, StatLevelSaver statLevelSaver)
        {
            _statLevelSaver = statLevelSaver;
            _upgradesUpgradesConfig = upgradesUpgradesConfig;
        }

        public int PowerValue => _upgradesUpgradesConfig.PowerStatList[_statLevelSaver.PowerLevel].Value;
        public int SpeedValue => _upgradesUpgradesConfig.SpeedStatList[_statLevelSaver.SpeedLevel].Value;
        public int ArmorValue => _upgradesUpgradesConfig.ArmorStatList[_statLevelSaver.ArmorLevel].Value;        
        
        public int PowerCost => _upgradesUpgradesConfig.PowerStatList[_statLevelSaver.PowerLevel].Cost;
        public int SpeedCost => _upgradesUpgradesConfig.SpeedStatList[_statLevelSaver.SpeedLevel].Cost;
        public int ArmorCost => _upgradesUpgradesConfig.ArmorStatList[_statLevelSaver.ArmorLevel].Cost;
    }
}