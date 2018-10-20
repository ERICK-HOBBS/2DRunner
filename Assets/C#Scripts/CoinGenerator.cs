using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

    public ObjectPooler coinPool;

    public float distanceBetweenCoins;

    public void SpawnCoins(Vector3 startPosistion)
    {
        GameObject coin1 = coinPool.GetPooledObject();
        coin1.transform.position = startPosistion;
        coin1.SetActive(true);

        GameObject coin2 = coinPool.GetPooledObject();
        coin2.transform.position = new Vector3(startPosistion.x - distanceBetweenCoins, startPosistion.y, startPosistion.z);
        coin2.SetActive(true);

        GameObject coin3 = coinPool.GetPooledObject();
        coin3.transform.position = new Vector3(startPosistion.x + distanceBetweenCoins, startPosistion.y, startPosistion.z);
        coin3.SetActive(true);
    }
}
