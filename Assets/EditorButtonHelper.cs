using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

static public class EditorButtonHelperExtend
{
    public static void AddListener(this InputField value, Component component, UnityAction<string> unityAction)
    {
        value.onEndEdit.AddListener(unityAction);

#if UNITY_EDITOR
        EditorButtonHelper editorButtonHelper = value.gameObject.AddComponent<EditorButtonHelper>();
        editorButtonHelper.Init(component, unityAction);
#endif
    }

    public static void AddListener(this Button value, Component component, UnityAction unityAction)
    {
        value.onClick.AddListener(unityAction);

#if UNITY_EDITOR
        EditorButtonHelper editorButtonHelper = value.gameObject.AddComponent<EditorButtonHelper>();
        editorButtonHelper.Init(component, unityAction);
#endif
    }
}

public class EditorButtonHelper : MonoBehaviour
{
    public Component from;
    public string component;
    public string Method;
#if UNITY_EDITOR
    internal void Init(Component component, UnityAction unityAction)
    {
        InitValue(component);
        this.Method = unityAction.Method.ToString();
    }

    internal void Init(Component component, UnityAction<string> unityAction)
    {
        InitValue(component);
        this.Method = unityAction.Method.ToString();
    }

    private void InitValue(Component component)
    {
        this.from = component;
        var names = component.GetType().ToString().Split('.');
        this.component = names[names.Length - 1];
    }
#endif
}
