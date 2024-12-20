using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToolBox.Extensions
{
    public static class ObjectExtensions
    {
        public static bool HasComponent<T>(this UnityEngine.Component obj)
        {
            return obj.GetComponent<T>() != null;
        }

        public static bool HasComponent(this UnityEngine.Component obj, Type type)
        {
            return obj.GetComponent(type) != null;
        }

        public static Component AddComponent(this Component component, Type type)
        {
            return component.gameObject.AddComponent(type);
        }

        public static T AddComponent<T>(this Component component) where T : Component
        {
            return component.gameObject.AddComponent<T>();
        }
    } 

}
