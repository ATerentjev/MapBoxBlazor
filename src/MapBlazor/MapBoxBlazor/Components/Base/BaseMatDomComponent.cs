﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MatBlazor;

namespace MatBlazor
{
    public abstract class BaseMatDomComponent : BaseMapBoxComponent
    {
        [Parameter]
        public string Id { get; set; } = IdGeneratorHelper.Generate("matBlazor_id_");

        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; }


        private ElementReference _ref;

        /// <summary>
        /// Returned ElementRef reference for DOM element.
        /// </summary>
        public virtual ElementReference Ref
        {
            get => _ref;
            set
            {
                _ref = value;
                RefBack?.Set(value);
            }
        }

        [CascadingParameter]
        public MatTheme Theme { get; set; }

        protected ClassMapper ClassMapper { get; } = new ClassMapper();


        protected BaseMatDomComponent()
        {
            ClassMapper
                .Get(() => this.Class)
                .Get(() => this.Theme?.GetClass());
            
            StyleMapper.Get(() => Style);
        }

        /// <summary>
        /// Specifies one or more classnames for an DOM element.
        /// </summary>
        [Parameter]
        public string Class
        {
            get => _class;
            set { _class = value; }
        }


        /// <summary>
        /// Specifies an inline style for an DOM element.
        /// </summary>
        [Parameter]
        public string Style
        {
            get => _style;
            set { _style = value; }
        }


        protected StyleMapper StyleMapper = new StyleMapper();

        private string _class;
        private string _style;
    }
}