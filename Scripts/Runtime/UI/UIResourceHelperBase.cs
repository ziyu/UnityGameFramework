using GameFramework.UI;
using GameFramework.Resource;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UI资源辅助器
    /// </summary>
    public abstract class UIResourceHelperBase : MonoBehaviour, IUIResourceHelper
    {
        /// <summary>
        /// 加载资源
        /// </summary>
        /// <param name="assetName"></param>
        /// <param name="priority"></param>
        /// <param name="loadAssetCallbacks"></param>
        /// <param name="userData"></param>
        public abstract void LoadAsset(string assetName, int priority, LoadAssetCallbacks loadAssetCallbacks, object userData);

        /// <summary>
        /// 设置资源管理器
        /// </summary>
        /// <param name="resourceManager"></param>
        public abstract void SetResourceManager(IResourceManager resourceManager);
    }
}