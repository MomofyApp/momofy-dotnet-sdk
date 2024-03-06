
## Momofy .NET SDK 

Officially supported momofy package for .Net applications.


**Some useful resources**

Visit the [Documentation](https://momofy.readme.io/)

Goto the  [Dashboard](https://app.momofy.com/)









### Installation

To install this package run

```bash
  dotnet add package momofy-dotnet-sdk --version 1.0.0
```



### Environment Variables

To be able to perform transactions using this SDK you need to get your API Secret Key from your Momofy Dashboard.

`eg. secret_test_01HPH70VG02DAYJ1N70NP4QWKV`




#### Envronment Types


|  | Example     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Test`      | `secret_test_01HPH70VG02DAYJ1N70NP4QWKV` | Use test enviroment during project development |
| `Production`      | `secret_prod_01HPH70VG02DAYJ1N70NP4QWKV` | Use production enviroment for live application |



## Usage

```c#
MomofyClient momofyClient  = new MomofyClient("your_secret_key");
```

### Initiate Transaction

Request payment from your customers

```c#
momofyClient.RequestPayment(PaymentRequest object)

```


#### Request Response

```c#


```
###
#### options


|  Params |   Example values  | Description                       |
| :-------- | :------- | :-------------------------------- |
| `amount`      | `20` or "30" | Amount to be requested from customer |
| `channel`      | `mobile_money` | Only mobile money channel is currently being supported |
| `currency`      | `GHS` | The supported currency from the provider |    
| `customer`      | `Customer Object`  | The customer information|   
| `provider`      | `MTN or VODAFONE`  | Network Provider code ( get this from the docs )|  
| `reference_code`      | `unique uuidv4 number`  | Reference code ( will be auto generated when not provided )|  
| `transaction_note`      | `Message for transaction`  |Note to display to user when requesting for payment.| 

###
#### Customer Object

|  Params |   Required  | Description                       |
| :-------- | :------- | :-------------------------------- |
| `name`      | Yes | Name of the customer |
| `phone_number`      | Yes | Momo number of customer to be charged. |
| `email`      | Yes | Email of the customer (if not available provide organisation email)|




### Verify Transaction Status

Verify your transaction by providing the transaction ref ID. 

```c#

```
###

#### Verification Response


```c#


```

###

#### Transaction Status Type

|  Status |  Description                       |
| :-------- | :------- | 
| `initiated`      | Transaction has been initiated|
| `pending`      | Transaction has been successfully sent to the provider |
| `success`      | Transaction was process successfully|
| `failed`      | Transaction has failed means (may be the user declined the payment request or something bad has happened )|

## Feedback

If you have any feedback, Feel free to open an issue

