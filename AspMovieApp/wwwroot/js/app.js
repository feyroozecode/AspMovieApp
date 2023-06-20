import Vue from 'vue'
import MovieComponentVue from '../../Components/MovieComponent.vue'

new Vue({
    el: '#app',
    components: {
        MovieComponentVue
    },
    template: '<MovieComponent />'
})