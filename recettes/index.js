const apiKey = "5883392a77214b549c023c215f4b54d3"

const buttonRecherche = document.getElementById("submitRecipe")

const getRecipe = async (recipe) => {
    let reponse  = await fetch(`https://api.spoonacular.com/recipes/complexSearch?apiKey=${apiKey}&query=${recipe}"&number=2`)
    let recipes = await reponse.text();
    return recipes;
}
   

buttonRecherche.onclick = () => {
    let pate = document.getElementById("recipe").value
    console.log("recette avec : "+pate)
    getRecipe(pate).then((data)=>console.log("data"+data))
    
}
