# C# ECommerce/WMS Project
<table><tr><td><h1>MegaMicro: <br>The Leading online computer parts retailer!</h1></td></tr></table>
<br>
This project is destined to be a business WMS with direct integration with the ECommerce store front.
<br><br>
<em>This project wil develop over time using different approaches at different times or even the same time. The ECommerce/WMS project will be set-up with the following milestones:</em>
<hr>
- [ ] 1. There will be a basic store front, generally correct but nowhere near the finished product. <em>(Also my pages may be bold for purposes of distinguishing my project from others I am currently working on.)</em>
<br>
- [ ] 2. Creating an API for accessing data from the front-end
<br>
- [ ] 3. Integrating a database for the front-end to verify, this will most likely end with RavenDB(NoSQL) as the front-end DB but I may start with MySQL due to my familiarity.
<br>
- [ ] 4. TEST database(s) and API
<br>
- [ ] 5. Create a new Admin area to oversee the store(physical or virtual) AND be able to OBSERVE (only) other departments.
<br>
- [ ] 6. New RDBMS for managaing the backend.
<br>
- [ ] 7. Create new User Roles
<br>
- [ ] 8. Access limitations of new users
<br>
<br>
<table><tr><td>Once above completed I will update with more!</td></tr></table>
<br>
<em>There is no login at this time because it is in development and who wants to login everytime you make a change?</em>

Intentions of this project is to create a turn-key system for companies to use to manage a store(physical, online), inventory, sales, CRM, Payment integration, shipping, warehouse management and more. 

Technology to be used: (These may change over time)
- ***RavenDB*** for ecommerce store products/services
- ***MySQL***(or another RDBMS) for use in storing sensitive information securely, i.e., customers information
- **InfluxDB** to be used later for creating customer and warehouse performance data
- ***API Creation*** to secure information more securely
- ***APIs*** for communicating to the database(s)
- ***User Roles*** such as admin, analyst, warehouse management, online management, worker management and setting well-defined roles
- **Sales** Status on sales numbers, in 'real-time' chart form
- **CRM** for customer retention and engagement
- **Payment Integration** with mulitiple payment processors
- **Shipping** Integrating common shipping methods,(USPS, UPS, FedEx, etc)
- ***Warehouse Management*** will encompass the basics (as this would be a purpose-built package for a business) of WMS with options for more functionality, such as:
    - INVENTORY
        - Product Locations
        - Receiving
        - Order Retrieval
        - Incorporating physical technology(Scanners: Hand-held, multi-scan system, etc)


Technology used at this time (most likely will change)
1. .Net 3.1
2. ASP.Net MVC
3. Entity Framework Core Design
4. Pomelo Entity Framework MySQL
