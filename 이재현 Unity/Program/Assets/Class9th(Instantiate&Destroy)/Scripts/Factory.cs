using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    SLIME,
    WRAITH  
}
public class Factory : MonoBehaviour
{
    public Wraith wraith;
    public Slime slime;

  public void Create(UnitType unittype)
    {
        Unit unit = null;
        float x = Random.Range(0.0f, 5.0f); // 0~ 4.99...까지  정수이면 0 ~4
        float z = Random.Range(0.0f, 5.0f);
        switch(unittype)
        {
            case UnitType.SLIME: unit = Instantiate(slime, new Vector3(x, 0, z), Quaternion.identity);
                break;
            case UnitType.WRAITH: unit = Instantiate(wraith, new Vector3(x, 0, z), Quaternion.identity);
                break;
                
               
        }
        unit.Move();
                
    }
    
}
