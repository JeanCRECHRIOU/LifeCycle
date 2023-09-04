// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;


var collection = new ServiceCollection();
collection.AddSingleton<Singleton>();
collection.AddScoped<Scope>();
collection.AddTransient<Transient>();

var builder = collection.BuildServiceProvider();

Parallel.For(1, 10, i =>
{
    //Console.Clear();
    Console.WriteLine($"SingletonId = {builder.GetService<Singleton>().GetHashCode().ToString()}");
    Console.WriteLine($"TransientId = {builder.GetService<Transient>().GetHashCode().ToString()}");
    Console.WriteLine($"ScopeId = {builder.GetService<Scope>().GetHashCode().ToString()}");
});



public class Scope { }
public class Transient{}
public class Singleton { }
