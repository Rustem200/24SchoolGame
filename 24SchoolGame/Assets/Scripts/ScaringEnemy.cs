using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaringEnemy : MonoBehaviour
{
    private bool _isScaringNumberIncrease;
    [SerializeField] private float _scaringTime;
    private int _scaringNumber;
    public bool isScaring;

   
    



    public void IncreaseIsScaring(bool isScaringNumberIncrease)
    {
        _isScaringNumberIncrease = isScaringNumberIncrease;
        if (isScaringNumberIncrease = true)
            StartCoroutine(IScaring());
        else if(isScaringNumberIncrease = false)
        {
            StopAllCoroutines();
            _scaringNumber = 0;

        }
    }



    public void Scaring()
    {
        _scaringNumber = 0;
        isScaring = false;
        
    }

    IEnumerator IScaring()
    {
        while (_isScaringNumberIncrease)
        {
                yield return new WaitForSeconds(_scaringTime);
                _scaringNumber += 10;
            if (_scaringNumber >= 30)
                isScaring = true;
            else       
                isScaring = false;
            
        }
    }
}
