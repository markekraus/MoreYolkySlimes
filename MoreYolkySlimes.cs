using Il2Cpp;
using MelonLoader;
using MelonLoader.Preferences;

namespace MoreYolkySlimes
{
    internal class Entry : MelonMod
    {
        private MelonPreferences_Category _configCategory;
        private MelonPreferences_Entry<float> _triggerChance;
        private const float _triggerChanceDefault = 0.05f;

        public override void OnInitializeMelon()
        {
            _configCategory = MelonPreferences.CreateCategory("MoreYolkySlimes");
            _triggerChance = _configCategory.CreateEntry<float>(
                "YolkySpawnChance",
                _triggerChanceDefault,
                "Yolky Spawn Chance", 
                "Percent chance (as a decimal: '5%' is '0.05') that Yolky Slimes will spawn from nests. Game default is 0.004. Mod default is 0.05",
                false,
                false,
                new ValueRange<float>(0.0f, 1.0f));
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (!sceneName.StartsWith("zone") || !sceneName.Contains("_"))
                return;

            int count = 0;
            foreach (var yolkySpawnerTrigger in Utility.GetAll<SpawnerTrigger>("YolkySpawner"))
            {
                yolkySpawnerTrigger.chanceOfTrigger = _triggerChance.Value;
                count++;
            }
            LoggerInstance.Msg($"Updated {count} Yolky Spawners in {sceneName} to {_triggerChance.Value}.");
        }
    }
}
