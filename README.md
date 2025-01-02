# Welcome to Innfinity! 🌌
  <p><em>Your one-stop solution for an infinite choices of inns. Just don't forget to pack your magnet, to attract all the good deals 🤝🧲</em></p>

<br>

## 🗺 Overview
  <p>Innfinity is a feature-rich application built with ASP.NET Core 8, designed to make hotel booking a breeze for travelers while offering a robust management system for administrators.    
    Whether you're a customer looking for the perfect getaway or an admin managing hundreds of hotels, Innfinity has you covered!</p>
  <p>This project was meticulously planned and tracked using Jira, ensuring that every feature was delivered on time and to the highest quality standards. From authentication to testing,   
    every aspect of the platform was crafted with care!</p>
  <p>Below, you can find the Entity Relationship Diagram (ERD) that illustrates the database design. It captures all essential relationships and entities, ensuring a solid foundation for   
    data storage and retrieval:</p>

  <img src="/images/HotelBookingPlatformERD.png" alt="Hotel Booking Platform ERD">

<br>

  <p><strong>About the ERD:</strong> This diagram is the blueprint of the platform's database. Here's a quick breakdown of the key entities:
    <ul>
      <li><strong>Booking:</strong> Tracks reservations with details like check-in/out dates, total price, and status.</li>
      <li><strong>User:</strong> Represents customers and admins, each with roles and personal details.</li>
      <li><strong>Hotel:</strong> Captures hotel information such as name, rating, amenities, and location.</li>
      <li><strong>Room:</strong> Defines room-specific data like capacity, type, and pricing, linked to hotels.</li>
      <li><strong>Review:</strong> Lets users leave feedback, which is tied to their confirmed bookings.</li>
      <li><strong>City:</strong> Stores details of cities where hotels are located, ensuring geographic context.</li>
      <li><strong>FeaturedDeal:</strong> Highlights special offers, providing start and end dates for discounts.</li>
      <li><strong>Images:</strong> Includes <code>RoomImage</code> and <code>HotelImage</code> for visual content, making the platform more engaging.</li>
    </ul>
  The relationships between these entities are carefully designed to ensure data integrity and scalability, enabling robust query performance and a seamless user experience.</p>
  
<br>

## 🌟 Features
  <ul>
    <li><strong>🔐 JWT Authentication:</strong> Secure access to the API using JSON Web Tokens. No more password nightmares!</li>
    <li><strong>🛃 Custom Claims-Based Role Authorization:</strong> Fine-grained access control with roles like <code>Admin</code> and <code>Customer</code>.</li>
    <li><strong>🕵️‍♀️ Fluent Validation:</strong> Keep those form submissions tidy and error-free with clean, expressive validation rules.</li>
    <li><strong>🔁 AutoMapper:</strong> Simplify data mapping like a boss. Because who wants to write boilerplate code?</li>
    <li><strong>🦸‍♀️ Serilog:</strong> Log everything and feel like a superhero during debugging.</li>
    <li><strong>Layered Architecture:</strong> Clear separation of concerns with three layers:
      <ul>
        <li><strong>🎮 API:</strong> The gateway to our application (Controllers).</li>
        <li><strong>📐 Domain:</strong> Where business logic lives and thrives.</li>
        <li><strong>🗃 Infrastructure:</strong> Managing the database repositories like a pro.</li>
      </ul>
    </li>
  </ul>

<br> 

## 🤹‍♀️ Technologies Used</h2>
  <ul>
    <li><strong>ASP.NET Core 8</strong></li>
    <li><strong>Entity Framework Core</strong> for ORM goodness</li>
    <li><strong>SQL Server</strong> for database management</li>
    <li><strong>FluentValidation</strong> for input validation</li>
    <li><strong>AutoMapper</strong> for object-object mapping</li>
    <li><strong>Serilog</strong> for structured logging</li>
    <li><strong>JWT Bearer Authentication</strong> for secure access</li>
    <li><strong>Custom Claims</strong> for role-based security</li>
    <li><strong>XUnit</strong> for the delivery of well-tested features</li>
  </ul>
  
<br>
  
## 🏁 Getting Started
  
  ### Prerequisites
    
   <ul>
     <li>.NET 8 SDK</li>
     <li>SQL Server</li>
     <li>Visual Studio, Rider, or whatever your geeky mind finds peace using</li>
     <li>A sense of adventure (and probably some coffee).</li>
   </ul>
  
 ### Steps to Run
   
   <ol>
     <li>Clone the repository: <code>git clone https://github.com/Janaherself/Hotel-Booking-Platform.git</code></li>
     <li>Navigate to the solution directory and open it in your IDE.</li>
     <li>Set up the database connection string in <code>appsettings.json</code>.</li>
     <li>Run the migrations to set up the database: <code>dotnet ef database update</code>.</li>
     <li>Build and run the solution. Happy booking!</li>
   </ol>
   
<br>
   
## 🔬 How It Works

  ### Authentication & Authorization
   <p>Authentication is handled using JWT. Each user gets a token after successful login, which must be included in the <code>Authorization</code>
     header for subsequent requests. Role-based access ensures that admins and customers stay in their lanes.</p>
  
  ### Validation
   <p>FluentValidation takes care of input validation like a hawk. Whether it's a new booking or user registration, invalid data won't pass through.</p>
  
  ### Logging
   <p>Serilog logs every crucial operation. If something goes wrong, you'll know exactly when, where, and why.</p>
  
  ### Architecture
   <p>The project uses a layered approach for scalability and maintainability. The API layer handles client communication, the Domain layer manages the core logic,
     and the Infrastructure layer ensures smooth database interaction.</p>
     
<br>
               
 ## 📝 Testing
   <p>The platform includes comprehensive unit tests for all layers. JWT-protected controllers are tested with mocked dependencies to ensure security and functionality.</p>
    
<br>
          
## 👩‍💻 Contributing
  <p>Want to contribute? Fork the repo, create a new branch, and start making magic. Pull requests are welcome, but please keep your code clean and your humor cleaner.</p>

<br>

  <p><strong>Bright and HUGE enhancements are on the way 🚀</strong> and you can always be part of it!</p>  

<br>

> **<p><strong>Disclaimer:</strong> I tend to forget awaiting calls to asynchronous methods, if you think you're too, maybe contributing to this project, with all due respect, is not what you're looking for here 🥰</p>**
