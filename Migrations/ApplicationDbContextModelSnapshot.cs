﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _72220556sampleWebApp.data;
using SampleSecureWeb.Models;
namespace _72220556sampleWebApp.Migrations;
public class ApplicationDbContext : DbContext
 {
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
{
}

public DbSet<Student> Students { get; set; } = null!;
public DbSet<User> Users { get; set; } = null!;
}   
   