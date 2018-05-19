﻿namespace MvcSalesApp.DependencyResolution
{
  using StructureMap;
  using StructureMap.Graph;
  using StructureMap.Graph.Scanning;
  using StructureMap.Pipeline;
  using StructureMap.TypeRules;
  using System;
  using System.Web.Mvc;
  using WebGrease.Css.Extensions;

  public class ControllerConvention : IRegistrationConvention
  {
    #region Public Methods and Operators

    public void Process(Type type, Registry registry) {
      if (type.CanBeCastTo<Controller>() && !type.IsAbstract) {
        registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
      }
    }

    public void ScanTypes(TypeSet types, Registry registry) {
      types.AllTypes().ForEach(type =>
      {
        if (type.CanBeCastTo<Controller>() && !type.IsAbstract) {
          registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
        }
      });
    }

    #endregion Public Methods and Operators
  }
}