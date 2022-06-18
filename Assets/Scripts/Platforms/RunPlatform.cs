using UnityEngine;

public class RunPlatform : MonoBehaviour
{
    private SliderJoint2D slider;
    private JointMotor2D motor2D;

    private void Start()
    {

        slider = gameObject.GetComponent<SliderJoint2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        motor2D = slider.motor;
        motor2D.motorSpeed *= -1;
        slider.motor = motor2D;
    }
}
