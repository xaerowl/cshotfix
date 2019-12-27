
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_TestTools_CoveredMethodStats_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TestTools.CoveredMethodStats);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_0);

            field = type.GetField("method", flag);
            app.RegisterCLRFieldGetter(field, get_method_0);
            app.RegisterCLRFieldSetter(field, set_method_0);
            field = type.GetField("totalSequencePoints", flag);
            app.RegisterCLRFieldGetter(field, get_totalSequencePoints_1);
            app.RegisterCLRFieldSetter(field, set_totalSequencePoints_1);
            field = type.GetField("uncoveredSequencePoints", flag);
            app.RegisterCLRFieldGetter(field, get_uncoveredSequencePoints_2);
            app.RegisterCLRFieldSetter(field, set_uncoveredSequencePoints_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TestTools.CoveredMethodStats());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TestTools.CoveredMethodStats[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TestTools.CoveredMethodStats instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TestTools.CoveredMethodStats[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* ToString_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.TestTools.CoveredMethodStats instance_of_this_method = (UnityEngine.TestTools.CoveredMethodStats)typeof(UnityEngine.TestTools.CoveredMethodStats).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.ToString();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_method_0(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredMethodStats)o).method;
        }
        static void set_method_0(ref object o, object v)
        {
UnityEngine.TestTools.CoveredMethodStats _o = (UnityEngine.TestTools.CoveredMethodStats)o;
    _o.method = (System.Reflection.MethodBase)v;
        }
        static object get_totalSequencePoints_1(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredMethodStats)o).totalSequencePoints;
        }
        static void set_totalSequencePoints_1(ref object o, object v)
        {
UnityEngine.TestTools.CoveredMethodStats _o = (UnityEngine.TestTools.CoveredMethodStats)o;
    _o.totalSequencePoints = (System.Int32)v;
        }
        static object get_uncoveredSequencePoints_2(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredMethodStats)o).uncoveredSequencePoints;
        }
        static void set_uncoveredSequencePoints_2(ref object o, object v)
        {
UnityEngine.TestTools.CoveredMethodStats _o = (UnityEngine.TestTools.CoveredMethodStats)o;
    _o.uncoveredSequencePoints = (System.Int32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TestTools.CoveredMethodStats();
            ins = (UnityEngine.TestTools.CoveredMethodStats)o;
            return ins;
        }


    }
}
#endif
