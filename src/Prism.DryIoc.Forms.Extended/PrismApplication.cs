﻿using Prism.Ioc;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

[assembly: InternalsVisibleTo("Prism.DryIoc.Forms.Extended.Tests")]
[assembly: XmlnsDefinition("http://prismlibrary.com", "Prism.DryIoc")]
namespace Prism.DryIoc
{
    public abstract class PrismApplication : PrismApplicationBaseExtended
    {
        public PrismApplication()
        {
        }

        public PrismApplication(IPlatformInitializer platformInitializer) 
            : base(platformInitializer)
        {
        }

        public PrismApplication(IPlatformInitializer platformInitializer, bool setFormsDependencyResolver) 
            : base(platformInitializer, setFormsDependencyResolver)
        {
        }

        protected override IContainerExtension CreateContainerExtension() => PrismContainerExtension.Current;
    }
}
