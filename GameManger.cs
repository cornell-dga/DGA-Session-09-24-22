using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
  public GameObject platform;
  public float width = 3f;
  public float minY = .2f;
  public float maxY = 1f;
  public float numberOfPlatforms = 150f;

  // Start is called before the first frame update
  void Start()
  {
    Vector3 spawnLocation = new Vector3();
    for (int i = 0; i < numberOfPlatforms; i++)
    {
      spawnLocation.y += Random.Range(minY, maxY);
      spawnLocation.x = Random.Range(-width / 2, width / 2);
      Instantiate(platform, spawnLocation, Quaternion.identity);
    }

  }

  // Update is called once per frame
  void Update()
  {

  }
}
