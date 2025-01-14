# Say Hi to Innfinity! 🌌
  <p><em>Your ultimate solution for infinite choices of inns. Just don't forget to pack a magnet, to attract all the good deals 🤝🧲</em></p>

<br>

## 🗺 Overview
  <p>Innfinity is a feature-rich web API built with ASP.NET Core 8, designed to make hotel booking a breeze for travelers while offering a robust management system for administrators.    
    Whether you're a customer looking for the perfect vacation or an admin managing hundreds of hotels, Innfinity has you covered!</p>
  <p>This project was carefully planned and tracked using Jira, ensuring that every feature was delivered on time and to the highest quality standards.
    From authentication to testing, every aspect of Innfinity was crafted with passion while utilizing clean code and SOLID principles to maintain high code quality and scalability.</p>

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
  The relationships between these entities were designed to ensure data integrity and scalability, enabling robust query performance and a seamless user experience.</p>
  
<br>

## 🌟 Features
  <ul>
    <li><strong>Search and Book Hotels:</strong> Effortlessly find and book hotels with advanced filtering options.</li>
    <li><strong>Manage Bookings:</strong> View, update, or cancel your bookings with ease.</li>
    <li><strong>Leave Reviews:</strong> Share your feedback on past stays.</li>
    <li><strong>Enjoy Promotions:</strong> Explore featured deals and discounts for your stays.</li>
    <li><strong>Admin Controls:</strong> Manage hotels, rooms, and cities via a robust admin panel.</li>
  </ul>

<br> 

## 🤹‍♀️ Technologies Used
  <ul>
    <li><strong>ASP.NET Core 8</strong></li>
    <li><strong>Entity Framework Core</strong> for ORM management</li>
    <li><strong>SQL Server</strong> for database management</li>
    <li><strong>FluentValidation</strong> for input validation</li>
    <li><strong>AutoMapper</strong> for object-object mapping</li>
    <li><strong>Serilog</strong> for structured logging</li>
    <li><strong>JWT Bearer Authentication</strong> for secure access</li>
    <li><strong>Custom Claims</strong> for role-based authorization</li>
    <li><strong>xUnit</strong> for the delivery of well-tested features</li>
    <li><strong>Moq</strong> for mocking dependencies in unit tests</li>
    <li><strong>FluentAssertions</strong> for friendly test assertions</li>
    <li><strong>Jira</strong> for project management and task tracking</li>
  </ul>
  
<br>
    
## 🔬 A Closer Look

  ### 🔐🛃 Authentication & Authorization
   <p>Authentication is handled using JWT. Each user gets a token after successful login, which must be included in the <code>Authorization</code>
     header for subsequent requests. Role-based access ensures that admins and customers stay in their lanes.</p>
  
  ### 🕵️‍♀️ Input Validation
   <p>FluentValidation takes care of input validation like a hawk. Whether it's a new booking or user registration, invalid data won't pass through.</p>
  
  ### 🦸‍♀️ Logging
   <p>Serilog logs every crucial operation. If something goes wrong, you'll feel like a superhero during debugging knowing how, why, and when everything happened.</p>
  
  ### 🧱 Architecture
   <p>Innfinity was built using a layered architecture for scalability, maintainability, and a clear separation of concerns with three layers:</p>
    <ul>
        <li><strong>🎮 API:</strong> The gateway to Innfinity, where the client communications take place in controllers.</li>
        <li><strong>📐 Domain:</strong> Where business logic lives and thrives.</li>
        <li><strong>🗃 Infrastructure:</strong> Managing the database interactions like a pro.</li>
      </ul>
      
   <p>The figure down below demonstrates the previous layeres and the interactions between them in Innfinity:</p>
   <p align="center"> 
     <img height="400px" src="/images/MyLayeredArchitecture.png" alt="Innfinity's Architecture">     
   </p>
 
  ### 🔁 Mapping
   <p>AutoMapper simplifies data mapping between layers like a boss. Because who wants to write boilerplate code?</p>

  ### 🚓 Error Handling
   <p>Innfinity uses a custom error handling middleware to catch, log, and peacefully contain any unexpected exceptions 
     to ensure a seamless user experience when errors happen -because they do happen all the time!</p>
               
  ### 📝 Testing
   <p>Innfinity includes comprehensive unit tests for all layers, as well as integration tests for the database. 
     JWT-protected controllers are tested with mocked dependencies to ensure security and functionality.</p>
    
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
 
## 💡 Example Usage
  <p>It’s booking time! here’s what to do:</p>

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
          
>  *<p>don't worry if your token expired, you can always get a new one by signing in using the same credentials you provided previously, just follow the following instructions</p>*
        </ul>
      <li><p>for already registered users, you can follow the same steps above, except that your request needs to be sent to <code>api/authentication/login</code></p></li>
      
>  *<p>very informative following instructions, right?! :)</p>*
      </ul>
    </li>
    <br>
    <li>
      <strong>Explore cities, hotels, and rooms</strong>
        <ul>
          <li>add <code>Authorization</code> to the request headers, the value of this header should be "<code>Bearer {your JWT token}</code>"</li>
          <li>send a <strong>GET</strong> request to:</li>
            <ul>
              <li><code>api/cities</code> to check out cities</li>
              <li><code>api/hotels</code> to check out hotels</li>
              <li><code>api/rooms</code> to check out rooms</li>
            </ul>
          <li>because this API cares about efficient data retrieval it implements pagination, so you can change the values of the following query parameters</li>
            <ul>
              <li><code>pageSize</code> to specify how many entities are retrieved in a request</li>
              <li><code>pageNumber</code> to specify what page you want to view</li>
            </ul>
          <li>memorize the IDs of your chosen rooms. you are only a few steps away from booking your first room!</li>
        </ul>
    </li>
    <br>
    <li>
      <strong>Create your booking</strong>
      <ul>
        <li>make sure that the <code>Authorization</code> header has a valid token just as in the previous step</li>
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
            <li><code>200 OK</code> if your booking has been successfully created</li>
            <li><code>401 Unauthorized</code> if your token has expired or is invalid</li>
            <li><code>400 BadRequest</code> if your booking has invalid data, with a complete list of your errors</li>
          </ul>
        <br>
        <li>if you accidently typed wrong details, or just changed your mind about the booking and want to modify it, updating a booking is as easy as:</li>
          <ul>
            <li>insert your token in the <code>Authorization</code> header</li>
            <li>send a <strong>POST</strong> request to <code>api/bookings</code>, and in the request body, you can update any the following properties:</li>
              <pre>
                {
                  "checkInDate": "2025-01-10",
                  "checkOutDate": "2025-01-15",
                  "totalPrice": 500.00,
                  "roomIds": [1, 2]
                }
              </pre>

> *<p>while you can provide any value to modify, it's important to provide both check-in and check-out dates, to properly validate your input</p>* 
          </ul>
      </ul>
      <br>
    </li>
  </ol>
  
  <p><strong><em>Your booking is all set! time to pack your bags! 🧳</em></strong></p>

  <br>

  <p>Feel free to explore the other endpoints to maximize your booking experience!</p>

  <ul>
    <li><code>api/users</code> for users with admin roles, to view all users</li>
    <li><code>api/hotel-images</code> for all users, to view hotels' images</li>
    <li><code>api/reviews</code> for all users, to view users' reviews to hotels</li>
    <li><code>api/featured-deals</code> for all users, to view hotels' newest deals</li>
    <li><code>api/recent-visited-hotels</code> for travelers, to discover the last 5 hotels you visited</li>
    <li><code>api/top-visited-cities</code> for all users, to explore the 5 most popular destinations in Innfinity</li>
  </ul>

  <br>
  
  <p>And for the next endpoints, don't forget to add your search query as a query parameter!</p>
  
  <ul>
    <li><code>api/hotels/amenities</code> for all users, to filter hotels by the amenities they provide</li>
    <li><code>api/hotels/cities</code> for all users, to filter hotels located in the given city</li>
    <li><code>api/hotels/ratings</code> for all users, to filter hotels by their rating</li>
    <li><code>api/rooms/prices</code> for all users, to filter rooms by their prices</li>
    <li><code>api/rooms/types</code> for all users, to filter rooms by their types</li>
    <li><code>api/rooms/children</code> for all users, to filter rooms by their children capacity</li>
    <li><code>api/rooms/adults</code> for all users, to filter rooms by their adults capacity</li>
  </ul>

<br>

> *<p>Admins are granted special permissions to Add, Update, and Delete all of the previously mentioned entities.</p>*
> *<p>Currently, the API can assign the admin role to two emails, but the list of emails is designed to be extensible.</p>*

<br>
          
## 👩‍💻 Contributing
  <p>Want to contribute? fork the repo, create a new branch, and start making magic. Pull requests are welcome, but please keep your code clean and organized 🧹</p>

<br>

  <p><strong>A bright future awaits Innfinity 🚀</strong> and your contributions can make it even brighter!</p>  

<br>

> **<p><strong>Disclaimer:</strong> I tend to forget awaiting calls to asynchronous methods, if you think you do too, maybe contributing to this project, with all due respect, is not what you're looking for here 🥰</p>**
