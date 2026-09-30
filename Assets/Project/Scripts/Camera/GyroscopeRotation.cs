using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeRotation : MonoBehaviour
{
    Gyroscope gyro;
    // Start is called before the first frame update
    void Start()
    {
       Screen.orientation = ScreenOrientation.LandscapeLeft; 
       Screen.sleepTimeout = SleepTimeout.NeverSleep;

       gyro = Input.gyro;
       gyro.enabled = true;

       Input.location.Start();
       Input.compass.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       ActualizarDatosGyro();
    }

    public void ActualizarDatosGyro()
    {
        Quaternion nuevo = Input.gyro.attitude;
        nuevo.x *= -1.0f;
        nuevo.y *= -1.0f;
        nuevo = Quaternion.Euler(90, 0, 0) * nuevo;
        nuevo.eulerAngles = new Vector3(nuevo.eulerAngles.x, nuevo.eulerAngles.y, nuevo.eulerAngles.z);
        transform.localRotation = nuevo;
    }
}