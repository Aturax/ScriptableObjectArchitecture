using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] FloatVariable playerHealth = null;
    [SerializeField] IntVariable intVariable = null;
    [SerializeField] BoolVariable boolVariable = null;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            playerHealth.Value -= 1f;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            playerHealth.Value += 1f;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            intVariable.Value -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            intVariable.Value += 1;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            boolVariable.Value = false;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            boolVariable.Value = true;
        }
    }
}
