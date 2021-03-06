﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
#endregion

namespace Blazorise.Base
{
    public abstract class BaseLabel : BaseComponent
    {
        #region Members

        private bool isCheck;

        private bool isFile;

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .If( () => ClassProvider.Label(), () => !IsFile && !IsCheck )
                .If( () => ClassProvider.LabelFile(), () => IsFile )
                .If( () => ClassProvider.LabelCheck(), () => IsCheck );

            base.RegisterClasses();
        }

        #endregion

        #region Properties

        [Parameter] protected string For { get; set; }

        [Parameter]
        protected bool IsCheck
        {
            get => isCheck;
            set
            {
                isCheck = value;

                ClassMapper.Dirty();
            }
        }

        [Parameter]
        protected bool IsFile
        {
            get => isFile;
            set
            {
                isFile = value;

                ClassMapper.Dirty();
            }
        }

        [Parameter] protected RenderFragment ChildContent { get; set; }

        #endregion
    }
}
