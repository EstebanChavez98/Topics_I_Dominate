const RESOURCE_NAME = 'https://localhost:44368/api/values';

Vue.component('modal', {
    template: '#modal-template'
})

const app = new Vue({
    el: '#app',
    name: 'modal',
    data: {
        name: '',
        dep: '',
        person: '',
        ip: '',
        showModal: false,
        info: ''
    },
    methods:{
        crearVisita() {
            axios.get(`${RESOURCE_NAME}/${this.name}&${this.dep}&${this.person}&${this.ip}&`)
            .then(response => this.info = response.data )
        },
        close() {
            this.$emit('close');
        }
    }
});