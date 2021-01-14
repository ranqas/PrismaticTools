
namespace PaladyumTools.Framework {
    public class ModConfig {
        public bool UseSprinklersAsScarecrows { get; set; }
        public bool UseSprinklersAsLamps { get; set; }
        public int SprinklerRange { get; set; }
        public int PaladyumToolLength { get; set; }
        public int PaladyumToolWidth { get; set; }
        public int PaladyumToolCost { get; set; }

        public ModConfig() {
            UseSprinklersAsScarecrows = true;
            UseSprinklersAsLamps = true;
            SprinklerRange = 4;
            PaladyumToolLength = 9;
            PaladyumToolWidth = 4;
            PaladyumToolCost = 300000;
        }
    }
}
