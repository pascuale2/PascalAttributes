using UnityEngine;

namespace PascalAttributes.Runtime
{
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class BuildSceneDropdownAttribute : PropertyAttribute { }
}
