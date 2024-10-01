using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounter;
    [SerializeField] private ButtonView _buttonView;

    private float _timeDelay = 0.5f;
    private Coroutine _corutine;
    private WaitForSeconds _expectation;
    private int _number;
    private bool _canCount;

    private void OnEnable()
    {
        _buttonView.Clicked += ChangeStatus;
    }

    private void OnDisable()
    {
        _buttonView.Clicked -= ChangeStatus;
    }

    private void Start()
    {
        _number = 0;
        _textCounter.text = _number.ToString();
        _expectation = new WaitForSeconds(_timeDelay);
        _canCount = false;
    }

    private void ChangeStatus()
    {
        _canCount = !_canCount;

        if (_corutine != null)
        {
            StopCoroutine(_corutine);
            _corutine = null;
        }
        else if (_canCount)
        {
            _corutine = StartCoroutine(CountUp());
        }
    }


    private IEnumerator CountUp()
    {
        while (true)
        {
            _number++;
            _textCounter.text = _number.ToString();
            yield return _expectation;
        }
    }
}
