using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);
            // �������� ������ �� ��������� ApplePicker ������� ������ Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            // ������� ������������� ����� AppleDestroyed() �� apScript
            apScript.AppleDestroyed();
        }
    }
}
