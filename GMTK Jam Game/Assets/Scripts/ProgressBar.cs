using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//#if UNITY_EDITOR
//using UnityEditor;
//#endif

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
//#if UNITY_EDITOR
//    [MenuItem("GameObject/UI/Linear Progress Bar")]
//    public static void AddLinearProgressBar()
//    {
//        GameObject obj = Instantiate(Resources.Load<GameObject>("UI/Linear Progress Bar"));
//        obj.transform.SetParent(Selection.activeGameObject.transform);
//    }
//#endif

    public int minimum;
    public int maximum;
    public int current;
    public Image mask;

    // Update is called once per frame
    void Update()
    {
        ClampValues();
        GetCurrentFill();
    }

    void ClampValues()
    {
        //Clamps current value between minimum and maximum
        current = (int)Mathf.Clamp(current, minimum, maximum);
        //Clamps minimum value under maximum - 1
        minimum = (int)Mathf.Clamp(minimum, 0.0f, maximum - 1.0f);
        //Clamps maximum value above minimum + 1
        maximum = (int)Mathf.Clamp(maximum, minimum, 1000000000.0f);
    }

    void GetCurrentFill()
    {
        float currentOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = (float)currentOffset / (float)maximumOffset;
        mask.fillAmount = fillAmount;
    }
}
