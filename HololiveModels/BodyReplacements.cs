using ModelReplacement;
using UnityEngine;

namespace ModelReplacement
{
    public class MRSROA2 : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Sroa2";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }public class MRIRYS : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Irys";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }public class MRIRYS2 : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "Irys2";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }public class MRMEL : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "Mel";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}