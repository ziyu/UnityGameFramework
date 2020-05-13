using GameFramework.Resource;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityGameFramework.Runtime
{
    public class DefaultUIResourceHelper : UIResourceHelperBase
    {
        private IResourceManager m_resourceManager;
        public override void LoadAsset(string assetName, int priority, LoadAssetCallbacks loadAssetCallbacks, object userData)
        {            
            m_resourceManager.LoadAsset(assetName, priority, loadAssetCallbacks, userData);
        }

        public override void SetResourceManager(IResourceManager resourceManager)
        {
            m_resourceManager = resourceManager;
        }
    }
}
