import time
import asyncio
import requests
#import prettytable

apiKey = "5883392a77214b549c023c215f4b54d3"


async def serveur_async():
    task1 = asyncio.create_task(getRecipe('pasta'))
    await task1
    
async def getRecipe(name):
    response = requests.get(f"https://api.spoonacular.com/recipes/complexSearch?apiKey={apiKey}&query={name}&number=2")
    result = await response
    print(result)

async def get_json(url):
    async with requests.get(url) as response:
        assert response.status == 200
        return await response.read()

async def get_reddit_top(subreddit):
    data1 = await get_json(subreddit)



if __name__ == '__main__':
    asyncio.run(get_reddit_top(f"https://api.spoonacular.com/recipes/complexSearch?apiKey={apiKey}&query=pasta&number=2"))