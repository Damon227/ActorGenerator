// ***********************************************************************
// Solution         : ActorGenerator
// Project          : ActorTemplate
// File             : TemplateConfiguration.cs
// Updated          : 2017-11-13 10:38
// ***********************************************************************
// <copyright>
//     Copyright © 2016 - 2017 Kolibre Credit Team. All rights reserved.
// </copyright>
// ***********************************************************************

namespace ActorTemplate
{
    public class TemplateConfiguration
    {
        /// <summary>
        ///     Folder or File
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     对应 TemplateSetting -> Name 的值
        /// </summary>
        public string ActorType { get; set; }

        /// <summary>
        ///     生成的文件路径
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        ///     文件模板路径
        /// </summary>
        public string Sources { get; set; }
    }
}