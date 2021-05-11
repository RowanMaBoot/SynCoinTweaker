using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;

namespace CoinTweaker.Settings
{
    public class GeneralSettings
    {
        [SynthesisOrder]
        public WeightSettings Weight = new();

        [SynthesisOrder]
        public NameSettings Name = new();

        [SynthesisOrder]
        public ValueSettings Value = new();
    }

    public class WeightSettings
    {
        [SynthesisOrder]
        public bool ReweightCoins = true;

        [SynthesisOrder]
        public float VanillaGoldWeight = 0.005f;

        [SynthesisOrder]
        public float CoinsofTamrielSilverCoinWeight = 0.008f;

        [SynthesisOrder]
        public float CoinsofTamrielGoldCoinWeight = 0.012f;

        [SynthesisOrder]
        public float NarrativeLootAncientCoinWeight = 0.008f;

        [SynthesisOrder]
        public float BeyondSkyrimAyleidCoinWeight = 0.008f;

        [SynthesisOrder]
        public float UniqueCoinsNordicCoinWeight = 0.012f;

        [SynthesisOrder]
        public float UniqueCoinsDwarvernCoinWeight = 0.012f;

    }

    public class NameSettings
    {
        [SynthesisOrder]
        public bool RenameCoins = true;

        [SynthesisOrder]
        public string RenameVanillaGoldCoinTo = "Septim";

        [SynthesisOrder]
        public string RenameCoinsofTamrielSilverCoinTo = "Silver Septim";

        [SynthesisOrder]
        public string RenameCoinsofTamrielGoldCoinTo = "Gold Septim";

        [SynthesisOrder]
        public string RenameNarrativeLootAncientCoinTo = "Ancient Coin";

        [SynthesisOrder]
        public string RenameBeyondSkyrimAyleidCoinTo = "Ayleid Mala";

        [SynthesisOrder]
        public string RenameUniqueCoinsNordicCoinTo = "Ancient Nordic Coin";

        [SynthesisOrder]
        public string RenameUniqueCoinsDwarvernCoinTo = "Dwemer Coin";
    }

    public class ValueSettings
    {
        [SynthesisOrder]
        public bool RevalueCoins = true;

        [SynthesisOrder]
        public uint RevalueCoinsofTamrielSilverCoinTo = 25;

        [SynthesisOrder]
        public uint RevalueCoinsofTamrielGoldCoinTo = 100;

        [SynthesisOrder]
        public uint RevalueNarrativeLootAncientCoinTo = 62;

        [SynthesisOrder]
        public uint RevalueBeyondSkyrimAyleidCoinTo = 1;

        [SynthesisOrder]
        public uint RevalueUniqueCoinsDwarvernCoinTo = 10;

        [SynthesisOrder]
        public uint RevalueUniqueCoinsNordicCoinTo = 5;
    }
}
