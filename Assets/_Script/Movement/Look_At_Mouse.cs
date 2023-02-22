using System;
using _Script.Movement;
using UnityEngine;
using UnityEngine.UIElements;

public class Look_At_Mouse : MonoBehaviour
{
    public GameObject face;
    public GameObject tongue;
    public GameObject eye_L;
    public GameObject eye_R;
    [Range(0, 1)] public float percent = 0.5f;
    public Camera mainCam;
    private CenterOrbiterMouse2D _leftEyeController;
    private CenterOrbiterMouse2D _rightEyeController;

    private void Start()
    {
        if (Camera.main != null) mainCam = Camera.main;
        _leftEyeController = new CenterOrbiterMouse2D(eye_L);
        _rightEyeController = new CenterOrbiterMouse2D(eye_R);
    }

    private void Update()
    {
        if (mainCam == null) return;
        if (Input.GetMouseButton(0))
        {
            tongue.SetActive(true);
            Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;

            eye_L.transform.position = _leftEyeController.OrbitBasedOnMouse(mousePos, percent);
            eye_R.transform.position = _rightEyeController.OrbitBasedOnMouse(mousePos, percent);
        }
        else
        {
            tongue.SetActive(false);
        }

        // float angle = Mathf.Atan2(mousePos.y, mousePos.x);
        // float y = Mathf.Sin(angle) * radius;
        // float x = Mathf.Cos(angle) * radius;
        // Debug.Log("x: " + x + " y: " + y);
        // var left = eye_L.transform.position;
        // eye_L.transform.position = new Vector3(x + left.x, y + left.y, 0f);
        // var right = eye_R.transform.position;
        // eye_R.transform.position = new Vector3(x + right.x, y + right.y, 0f);
    }
}