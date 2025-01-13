# Say Hi to Innfinity! 🌌
  <p><em>Your ultimate solution for infinite choices of inns. Just don't forget to pack a magnet, to attract all the good deals 🤝🧲</em></p>

<br>

## 🗺 Overview
  <p>Innfinity is a feature-rich web API built with ASP.NET Core 8, designed to make hotel booking a breeze for travelers while offering a robust management system for administrators.    
    Whether you're a customer looking for the perfect vacation or an admin managing hundreds of hotels, Innfinity has you covered!</p>
  <p>This project was carefully planned and tracked using Jira, ensuring that every feature was delivered on time and to the highest quality standards.
    From authentication to testing, every aspect of the platform was crafted with passion while utilizing clean code and SOLID principles to maintain high code quality and scalability.</p>

  <p>Below, you can find the Entity Relationship Diagram (ERD) that illustrates the database design. It captures all essential relationships and entities, ensuring a solid foundation for   
    data storage and retrieval:</p>

  <img src="/images/HotelBookingPlatformERD.png" alt="Innfinity's ERD">

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
    <li><strong>🔁 AutoMapper:</strong> Simplify data mapping between layers like a boss. Because who wants to write boilerplate code?</li>
    <li><strong>🦸‍♀️ Serilog:</strong> Log everything and feel like a superhero during debugging.</li>
    <li><strong>Layered Architecture:</strong> Clear separation of concerns with three layers:
      <ul>
        <li><strong>🎮 API:</strong> The gateway to our application (Controllers).</li>
        <li><strong>📐 Domain:</strong> Where business logic lives and thrives.</li>
        <li><strong>🗃 Infrastructure:</strong> Managing the database repositories like a pro.</li>
      </ul>
    </li>

   <p>The figure down below demonstrates the previous layeres and the interactions between them in Innfinity:</p>

   <img height="400px" src="/images/MyLayeredArchitecture.png" alt="Innfinity's Architecture">
 
  </ul>

<br> 

## 🤹‍♀️ Technologies Used</h2>
  <ul>
    <li><strong>ASP.NET Core 8</strong></li>
    <li><strong>Entity Framework Core</strong> for ORM management</li>
    <li><strong>SQL Server</strong> for database management</li>
    <li><strong>FluentValidation</strong> for input validation</li>
    <li><strong>AutoMapper</strong> for object-object mapping</li>
    <li><strong>Serilog</strong> for structured logging</li>
    <li><strong>JWT Bearer Authentication</strong> for secure access</li>
    <li><strong>Custom Claims</strong> for role-based security</li>
    <li><strong>XUnit</strong> for the delivery of well-tested features</li>
    <li><strong>Moq</strong> for mocking in unit tests</li>
    <li><strong>FluentAssertions</strong> for friendly test assertions</li>
    <li><strong>Jira</strong> for project management and task tracking</li>
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
     <li>Create the following environment variables on your machine <code>InnfinitySecretKey</code>, <code>InnfinityIssuer</code>, and <code>InnfinityAudience</code>.</li>
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

  ### Error Handling
   <p>Innfinity has a custom error handling middleware that is responsible for catching, logging, and peacefully handling any unexpected exception to ensure a seamless user experience when errors happen.</p>
   
<br>
               
## 📝 Testing
   <p>The platform includes comprehensive unit tests for all layers, as well as integration tests for the database. JWT-protected controllers are tested with mocked dependencies to ensure security and functionality.</p>
    
<br>

## Example API Usage
  <p>Below is an example of how to use the API to create a new booking:</p>

  <ol>
    <li>
      <strong>Login/Signup</strong>
      <ul>
      <li><p>for first-time users, create a new account by:</p></li>
        <ul>
          <li>send a <strong>POST</strong> request to <code>api/authentication/register</code></li>
          <li>inside the request body, insert a valid email address and a at-least 8 chars password as follows:
            <pre>
              {
                "email": "veryreal@emailaddress.com",
                "password": "morethan8charspassword"
              }
            </pre>
          </li>
          <li>if the registeration process completes as expected, you will find the generated JWT token in the response, this token is valid for only 30 minutes,
            and you will need it in later requests, so you better act fast!</li>      
          
>  *<p>don't worry if your token expired, you can always get a new one by signing in using the same credentials you provided previously, just follow the following instructions:</p>*
        </ul>
      <li><p>for already registered users, you can follow the same steps above, except that your request needs to be sent to <code>api/authentication/login</code>.</p></li>
      
>  *<p>very informative following instructions, right?! :)</p>*
      </ul>
    </li>
    <br>
    <li>
      <strong>Explore cities, hotels, and rooms</strong>
        <ul>
          <li>add <code>Authorization</code> to the request headers, the value of this header shoould be <code>Bearer {Your JWT Token}</code></li>
          <li>send a <strong>GET</strong> request to:</li>
            <ul>
              <li><code>api/cities</code> to view cities</li>
              <li><code>api/hotels</code> to view hotels</li>
              <li><code>api/rooms</code> to view rooms</li>
            </ul>
          <li>because this API cares about efficient data retrieval it implements pagination, so you can change the values of the following query parameters</li>
            <ul>
              <li><code>pageSize</code> to specify how many entities are retrieved in a request</li>
              <li><code>pageNumber</code> to specify what page you want to view</li>
            </ul>
          <li>memorize the IDs of your rooms of choice. now you are ready to book your first room!</li>
        </ul>
    </li>
    <br>
    <li>
      <strong>Create your booking</strong>
      <ul>
        <li>make sure that the <code>Authorization</code> header has a valid token ust as in the prvious step</li>
        <li>in the request body, make sure to provide values to all the following properties:</li>
          <pre>
            {
              "checkInDate": "2025-01-10",
              "checkOutDate": "2025-01-15",
              "totalPrice": 500.00,
              "roomIds": [1, 2]
            }
          </pre>
        <li>send a <strong>POST</strong> request to <code>api/bookings</code></li>
        <li>you should get a response as follows:</li>
          <ul>
            <li><p><code>200 OK</code> if your booking has been successfully created</p></li>
            <li><p><code>401 Unauthorized</code> if your token has expired or is invalid</p></li>
            <li><p><code>400 BadRequest</code> if your booking has invalid data</p></li>
          </ul>
      </ul>
    </li>
  </ol>
  
  <br>

  <p>Feel free to explore the other endpoints to maximize your booking experience!</p>

  <ul>
    <li><p><code>api/users</code> for users with admin roles, to view all users</p></li>
    <li><p><code>api/hotel-images</code> for all users, to view hotels' images</p></li>
    <li><p><code>api/reviews</code> for all users, to view users' reviews to hotels</p></li>
    <li><p><code>api/featured-deals</code> for all users, to view hotels' newest deals</p></li>
  </ul>

<br>

> *<p>Admins have special responsibilities of Adding, Updating, Deleting all of the previously mentioned entities.</p>*
> *<p>Currently, the API can assign the admin role to two emails, but the list of emails is designed to be extensible.</p>*

<br>
          
## 👩‍💻 Contributing
  <p>Want to contribute? Fork the repo, create a new branch, and start making magic. Pull requests are welcome, but please keep your code clean and organized 🧹</p>

<br>

  <p><strong>A bright future awaits Innfinity 🚀</strong> and your contributions can make it even brighter!</p>  

<br>

> **<p><strong>Disclaimer:</strong> I tend to forget awaiting calls to asynchronous methods, if you think you do too, maybe contributing to this project, with all due respect, is not what you're looking for here 🥰</p>**
