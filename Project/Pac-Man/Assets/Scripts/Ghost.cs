using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ghost : Entity
{
    NavMeshAgent navMashAgent;
    NavMeshPath path;
    public float timeForNewPath;
    bool isWorking;
    Vector3 target;
    bool validPath;

    private void Start()
    {
        navMashAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }

    public void Update()
    {
        if (!isWorking)
        {
            StartCoroutine(Pathing());
        }
    }

    Vector3 getNewRandomPosition ()
    {
        float x = Random.Range((float)-102.2,(float)112.4);
        float z = Random.Range((float)-107.4, (float)107.2);

        Vector3 pos = new Vector3(x, 1, z);
        return pos;
    }

    IEnumerator Pathing()
    {
        isWorking = true;
        yield return new WaitForSeconds(timeForNewPath);
        GetNewPath();
        validPath = navMashAgent.CalculatePath(target, path);
        if (!validPath) Debug.Log("Found an invalid path!");

        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f);
            GetNewPath();
            validPath = navMashAgent.CalculatePath(target, path);
        }
        isWorking = false;
    }

    void GetNewPath()
    {
        target = getNewRandomPosition();
        navMashAgent.SetDestination(target);
    }
}
