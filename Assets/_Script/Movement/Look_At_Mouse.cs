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
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        eye_L.transform.position = _leftEyeController.OrbitBasedOnMouse(mousePos, percent);
        eye_R.transform.position = _rightEyeController.OrbitBasedOnMouse(mousePos, percent);
    }
}