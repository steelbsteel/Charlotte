﻿#pragma checksum "..\..\..\Pages\Menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF35335CC25F1884FE7D476FC26F05341F8E39E7CAABEB0E4989BC34A42E179D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Charlotte;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Charlotte {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView bestHeroesList;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView bestSuperPowerList;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView bestEpisodesList;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HelpBtn;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateCharacter;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateSuperPower;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Pages\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateEpisode;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Charlotte;component/pages/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Menu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Pages\Menu.xaml"
            ((Charlotte.Menu)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\Menu.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExitClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 32 "..\..\..\Pages\Menu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OwnPagePreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\Pages\Menu.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OwnPagePreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 45 "..\..\..\Pages\Menu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CharactersWindowOpen);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 46 "..\..\..\Pages\Menu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SuperPowersWindowOpen);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 47 "..\..\..\Pages\Menu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EpisodesWindowOpen);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bestHeroesList = ((System.Windows.Controls.ListView)(target));
            
            #line 50 "..\..\..\Pages\Menu.xaml"
            this.bestHeroesList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.bestHeroesListDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bestSuperPowerList = ((System.Windows.Controls.ListView)(target));
            
            #line 65 "..\..\..\Pages\Menu.xaml"
            this.bestSuperPowerList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.bestSuperPowerListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bestEpisodesList = ((System.Windows.Controls.ListView)(target));
            
            #line 83 "..\..\..\Pages\Menu.xaml"
            this.bestEpisodesList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.bestEpisodesListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.HelpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Pages\Menu.xaml"
            this.HelpBtn.Click += new System.Windows.RoutedEventHandler(this.HelpBtnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CreateCharacter = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Pages\Menu.xaml"
            this.CreateCharacter.Click += new System.Windows.RoutedEventHandler(this.CreateCharacterBtnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CreateSuperPower = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Pages\Menu.xaml"
            this.CreateSuperPower.Click += new System.Windows.RoutedEventHandler(this.CreateSuperPowerClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.CreateEpisode = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\Menu.xaml"
            this.CreateEpisode.Click += new System.Windows.RoutedEventHandler(this.CreateEpisodeClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

