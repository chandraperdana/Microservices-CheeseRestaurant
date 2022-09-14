# Microservices-CheeseRestaurant

<h3> How to run the project : </h3>
<h3>1.	Change connection string in appsettings and run migrations for the following project (6 database will be created)</h3>
  <ul>
    <li>Cheese.CouponAPI</li>
    <li>Cheese.Services.Email</li>
    <li>Cheese.Services.Identity</li>
    <li>Cheese.Services.OrderAPI</li>
    <li>Cheese.Services.ProductAPI</li>
    <li>Cheese.Services.ShoppingCartAPI</li>
  </ul>
<h3>2.	Search term to change service bus connection string (do ctrl+shift+f and replace, should be 4 places) - sb://cheeserestaurant</h3>
<h3>3.	Create the following queues and topics/subscriptions in Azure Service bus.</h3>
<ul>
    <li>Queue - checkoutqueue</li>
    <li><span>Topic 1</span> - checkoutmessagetopic
      <ul>
        <li>Subscription (Topic 1) - cheeseOrderSubscription (subscription)</li>
      </ul>
    </li>
    <li>Topic 2 - orderpaymentprocesstopic
      <ul>
        <li>Subscription (Topic 2) - cheesePayment</li>
      </ul>
    </li>
    <li>Topic 3 - orderupdatepaymentresulttopic 
      <ul>
        <li>Subscription (Topic 3) - emailSubscription</li>
        <li>Subscription (Topic 3) - cheeseOrderSubscription</li>
      </ul>
    </li>
    <li>Cheese.Services.ProductAPI</li>
    <li>Cheese.Services.ShoppingCartAPI</li>
  </ul>
