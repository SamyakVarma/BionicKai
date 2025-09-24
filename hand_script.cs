using UnityEngine;
using UnityEngine.InputSystem;

public class hand_script : MonoBehaviour
{
    public Transform hand;

    [Header("Thumb Bones")]
    public Transform thumb1;
    public Transform thumb2;

    [Header("Index Finger Bones")]
    public Transform index1;
    public Transform index2;
    public Transform index3;

    [Header("Middle Finger Bones")]
    public Transform middle1;
    public Transform middle2;
    public Transform middle3;

    [Header("Ring Finger Bones")]
    public Transform ring1;
    public Transform ring2;
    public Transform ring3;

    [Header("Little Finger Bones")]
    public Transform little1;
    public Transform little2;
    public Transform little3;

    void Update()
    {
        // === Hand rotation ===
        if (Keyboard.current.rKey.isPressed)
            hand.Rotate(0f, 0f, -30f * Time.deltaTime);

        if (Keyboard.current.lKey.isPressed)
            hand.Rotate(0f, 0f, 30f * Time.deltaTime);

        // === Thumb ===
        if (Keyboard.current.tKey.isPressed)
            thumb1.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.gKey.isPressed)
            thumb2.Rotate(30f * Time.deltaTime, 0f, 0f);

        // === Index finger ===
        if (Keyboard.current.iKey.isPressed)
            index1.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.oKey.isPressed)
            index2.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.pKey.isPressed)
            index3.Rotate(30f * Time.deltaTime, 0f, 0f);

        // === Middle finger ===
        if (Keyboard.current.mKey.isPressed)
            middle1.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.nKey.isPressed)
            middle2.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.bKey.isPressed)
            middle3.Rotate(30f * Time.deltaTime, 0f, 0f);

        // === Ring finger ===
        if (Keyboard.current.yKey.isPressed)
            ring1.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.uKey.isPressed)
            ring2.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.jKey.isPressed)
            ring3.Rotate(30f * Time.deltaTime, 0f, 0f);

        // === Little finger ===
        if (Keyboard.current.kKey.isPressed)
            little1.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.hKey.isPressed)
            little2.Rotate(30f * Time.deltaTime, 0f, 0f);

        if (Keyboard.current.fKey.isPressed)
            little3.Rotate(30f * Time.deltaTime, 0f, 0f);
    }
}
