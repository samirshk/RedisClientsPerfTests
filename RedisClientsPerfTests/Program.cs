using BenchmarkDotNet.Running;
using System;

namespace RedisClientsPerfTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var redisboost = BenchmarkRunner.Run<RedisBoost>();

            var stackexchange = BenchmarkRunner.Run<StackExchange>();

            Console.ReadLine();
        }
    }
}
