# OpenSea-Wrapper
A complete C# wrapper around the [OpenSea API](https://docs.opensea.io/reference/api-overview). Allows you to retrieve different pieces of information relating to NFT's and NFT collections from OpenSea.

## OpenSea Solution
The complete, implemented C# API wrapper. Contains all API methods and calls provided by the OpenSea API. 

## OpenSeaTracker Solution
Contains some custom extension methods around OpenSea. Uses the API wrapper to do this. For example, the _GetAllAssetsByContract_ method gets all assets from a contract address, a procedure not directly supported by OpenSea, but made possible through the use of the API and the wrapper.
