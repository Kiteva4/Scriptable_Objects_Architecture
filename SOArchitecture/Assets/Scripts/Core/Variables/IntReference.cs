using UnityEngine;

[SerializeField]
public class IntReference : MonoBehaviour
{
    public bool UseConstant = true;
    public int ConstantValue;
    public IntVariable Variable;

    public int Value
    {
        get
        {
            return UseConstant ? ConstantValue :
                                 Variable.Value;
        }
    }
}
