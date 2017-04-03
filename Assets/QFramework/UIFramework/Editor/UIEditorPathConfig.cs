// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace QFramework {
    
    /// <summary>
    /// UI框架相关的路径
    /// </summary>
    public class UIEditorPathConfig {
        private const string m_ScriptGeneratorPath = "_Script/UI";
        private const string m_UIPrefabPath = "QArt/UIPrefab";
        private const string m_UIFactoryGeneratePath = "QFrameworkData/UI";
        /// <summary>
        /// 生成UI脚本的路径
        /// </summary>
        public static string ScriptGeneratorPath {
            get {
                return QFramework.Libs.IOUtils.CreateDirIfNotExists (UnityEngine.Application.dataPath + "/" + m_ScriptGeneratorPath);
            }
        }
        /// <summary>
        /// 生成UIPrefab的路径
        /// </summary>
        public static string UIPrefabPath {
            get {
                return QFramework.Libs.IOUtils.CreateDirIfNotExists (UnityEngine.Application.dataPath + "/" + m_UIPrefabPath);
            }
        }
        /// <summary>
        /// 生成UIFactory的路径
        /// </summary>
        public static string UIFactoryGeneratePath {
            get {
                return QFramework.Libs.IOUtils.CreateDirIfNotExists (UnityEngine.Application.dataPath + "/" + m_UIFactoryGeneratePath);
            }
        }
    }
}
