using System;
using UnityEngine;
//using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Collections;
/*
namespace Chromia.Postchain.Client
{
    public static class IEnumeratorAwaitExtensions
    {
        public class SimpleCoroutineAwaiter<T> : INotifyCompletion
        {
            bool _isDone;
            Exception _exception;
            Action _continuation;
            T _result;

            public bool IsCompleted
            {
                get { return _isDone; }
            }

            public T GetResult()
            {
                Debug.Assert(_isDone);

                if (_exception != null)
                {
                    ExceptionDispatchInfo.Capture(_exception).Throw();
                }

                return _result;
            }

            public void Complete(T result, Exception e)
            {
                Debug.Assert(!_isDone);

                _isDone = true;
                _exception = e;
                _result = result;

                // Always trigger the continuation on the unity thread when awaiting on unity yield
                // instructions
                if (_continuation != null)
                {
                    RunOnUnityScheduler(_continuation);
                }
            }

            void INotifyCompletion.OnCompleted(Action continuation)
            {
                Debug.Assert(_continuation == null);
                Debug.Assert(!_isDone);

                _continuation = continuation;
            }
        }


        public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
        {
            return GetAwaiterReturnSelf(instruction);
        }

        public static class SyncContextUtil
        {
            [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
            static void Install()
            {
                UnitySynchronizationContext = SynchronizationContext.Current;
                UnityThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            public static int UnityThreadId
            {
                get; private set;
            }

            public static SynchronizationContext UnitySynchronizationContext
            {
                get; private set;
            }
        }

        static void RunOnUnityScheduler(Action action)
        {
            if (SynchronizationContext.Current == SyncContextUtil.UnitySynchronizationContext)
            {
                action();
            }
            else
            {
                SyncContextUtil.UnitySynchronizationContext.Post(_ => action(), null);
            }
        }

        public class AsyncCoroutineRunner : MonoBehaviour
        {
            static AsyncCoroutineRunner _instance;

            public static AsyncCoroutineRunner Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new GameObject("AsyncCoroutineRunner")
                            .AddComponent<AsyncCoroutineRunner>();
                    }

                    return _instance;
                }
            }

            void Awake()
            {
                // Don't show in scene hierarchy
                gameObject.hideFlags = HideFlags.HideAndDontSave;

                DontDestroyOnLoad(gameObject);
            }
        }

        static IEnumerator ReturnSelf<T>(
            SimpleCoroutineAwaiter<T> awaiter, T instruction)
        {
            yield return instruction;
            awaiter.Complete(instruction, null);
        }

        static SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
        {
            var awaiter = new SimpleCoroutineAwaiter<T>();
            RunOnUnityScheduler(() => AsyncCoroutineRunner.Instance.StartCoroutine(
                ReturnSelf(awaiter, instruction)));
            return awaiter;
        }
    }
}*/