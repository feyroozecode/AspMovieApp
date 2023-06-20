<template>
    <div>
        <h2>Movies</h2>

        <ul class="movie-list">
            <li v-for="movie in movies" class="movie-item"> :key="movie.id"</li>
            <h3> {{ movie.title }} </h3>
            <p>Director : {{ movie.director }} </p>
            <p></p>
        </ul>

    </div>
</template>

<script>
    export default {
        data() {
            return {
                movies: []
            };
        },

        mounted() {
            fetchMovies(){
                fetch('./api/movies')
                    .then(response => response.json())
                    .then(data => {
                        this.movies = data;
                    })
                    .catch(error => {
                        console.log('Erreur: ', error);
                    });
            }
        }
    }
</script>

<style>
    .movie-list {
        list-style: none;
        padding: 0;
    }

    .movie-item {
          margin-bottom: 20px;
          border: 1px solid #ccc;
          padding: 10px;
          background-color: #f9f9f9;
    }

    .movie-item h3 {
        margin: 0;
        font-size: 18px;
    }

    .movie-poster {
        width: 200px;
        height: auto;
        margin-top: 10px;
    }

</style>