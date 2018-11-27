﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LobbyManager : MonoBehaviour
{
    public static int swit = 0;
    public static int btnInt = 0;
    public static string name;
    public static bool esc = false;
    public Transform ATKbar;
    public Transform ATKbar2;
    public Transform MVbar;
    public Transform Mvbar2;
    GameObject Animal;
    NavMeshAgent nav;
    public GameObject ship;

    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
    }
    public void Select()
    {
        if (name == "Pig")
        {
            Animal = GameObject.Find(name);
            nav = Animal.GetComponent<NavMeshAgent>();
            nav.SetDestination(transform.position);
            ESC();
        }
        if (name == "Dog")
        {
            Animal = GameObject.Find(name);
            nav = Animal.GetComponent<NavMeshAgent>();
            nav.SetDestination(transform.position);
            ESC();
        }
        if (name == "Cat")
        {
            Animal = GameObject.Find(name);
            nav = Animal.GetComponent<NavMeshAgent>();
            nav.SetDestination(transform.position);
            ESC();
        }
        if (name == "Wolf")
        {
            Animal = GameObject.Find(name);
            nav = Animal.GetComponent<NavMeshAgent>();
            nav.SetDestination(transform.position);
            ESC();
        }

    }

    public void ESC()
    {
        esc = true;
    }

    public void SelectATK() // 공격 명령 버튼누를시
    {
        if (btnInt == 0)
        {
            btnInt = 1;
            StartCoroutine(atkUp());
        }
    }
    public void anySelectATK() // 공격 조건선택시
    {
        StartCoroutine(atkDown());
        StartCoroutine(atkUp2());
    }
    public void anySelectATK2() // 공격 행동선택시
    {
        StartCoroutine(atkDown2());
        btnInt = 0;
    }

    public void SelectMV() // 이동 명령 버튼누를시
    {
        if (btnInt == 0)
        {
            btnInt = 1;
            StartCoroutine(mvUp());
        }
    }
    public void anySelectMV() // 이동 조건선택시
    {
        StartCoroutine(mvDown());
        StartCoroutine(mvUp2());
    }
    public void anySelectMV2() // 이동 행동 선택시
    {
        StartCoroutine(mvDown2());
        btnInt = 0;
    }
    public void StartBtn() // 날으는 배 애니메이션
    {
        ship.GetComponent<Animator>().enabled = true;
    }

    IEnumerator atkUp()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            ATKbar.Translate(0, 14f, 0);
        }
        yield return null;
    }
    IEnumerator atkDown()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            ATKbar.Translate(0, -14f, 0);
        }
        yield return null;
    }
    IEnumerator atkUp2()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            ATKbar2.Translate(0, 14f, 0);
        }
        yield return null;
    }
    IEnumerator atkDown2()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            ATKbar2.Translate(0, -14f, 0);
        }
        yield return null;
    }

    IEnumerator mvUp()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            MVbar.Translate(0, 14f, 0);
        }
        yield return null;
    }
    IEnumerator mvDown()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            MVbar.Translate(0, -14f, 0);
        }
        yield return null;
    }
    IEnumerator mvUp2()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            Mvbar2.Translate(0, 14f, 0);
        }
        yield return null;
    }
    IEnumerator mvDown2()
    {
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.01f);
            Mvbar2.Translate(0, -14f, 0);
        }
        yield return null;
    }
}
