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
    /// 一些配表相关的地址 可以不用的
    /// </summary>
    public class ToolPathConfig {
        private const string m_BUILD_CSHARP_WIN_SHELL = "table/output_code_csharp.bat";
        private const string m_BUILD_TXT_DATA_WIN_SHELL = "table/output_txt.bat";
        private const string m_BUILD_LRG_DATA_WIN_SHELL = "table/output_xc.bat";
        private const string m_BUILD_CSHARP_LINUX_SHELL = "table/output_code_csharp.sh";
        private const string m_BUILD_TXT_DATA_LINUX_SHELL = "table/output_txt.sh";
        private const string m_BUILD_LRG_DATA_LINUX_SHELL = "table/output_xc.sh";
        private const string m_ProjectToolsFolderPath = "../../../Tools/";
        /// <summary>
        /// windows shell table 生成代码的工具
        /// </summary>
        public static string BUILD_CSHARP_WIN_SHELL {
            get {
                return m_BUILD_CSHARP_WIN_SHELL;
            }
        }
        /// <summary>
        /// 应该是生成 binary的
        /// </summary>
        public static string BUILD_TXT_DATA_WIN_SHELL {
            get {
                return m_BUILD_TXT_DATA_WIN_SHELL;
            }
        }
        /// <summary>
        /// 不知道
        /// </summary>
        public static string BUILD_LRG_DATA_WIN_SHELL {
            get {
                return m_BUILD_LRG_DATA_WIN_SHELL;
            }
        }
        /// <summary>
        /// iOS平台 AB资源生成路径
        /// </summary>
        public static string BUILD_CSHARP_LINUX_SHELL {
            get {
                return m_BUILD_CSHARP_LINUX_SHELL;
            }
        }
        /// <summary>
        /// iOS平台 AB资源生成路径
        /// </summary>
        public static string BUILD_TXT_DATA_LINUX_SHELL {
            get {
                return m_BUILD_TXT_DATA_LINUX_SHELL;
            }
        }
        /// <summary>
        /// iOS平台 AB资源生成路径
        /// </summary>
        public static string BUILD_LRG_DATA_LINUX_SHELL {
            get {
                return m_BUILD_LRG_DATA_LINUX_SHELL;
            }
        }
        /// <summary>
        /// iOS平台 AB资源生成路径
        /// </summary>
        public static string ProjectToolsFolderPath {
            get {
                return UnityEngine.Application.dataPath + "/" + m_ProjectToolsFolderPath;
            }
        }
    }
}
