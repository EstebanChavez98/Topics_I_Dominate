const RESOURCE_NAME = 'https://localhost:44368/api/values';

var EModal = Vue.component('e-modal', {
    template: 
    `
    <div v-if="data.visible" class="e-modal">

            <div class="e-modal-body">
                <header><h3>Mensaje</h3></header>

                <section class="e-modal-message">
                    <p>{{ data.info }}</p>
                </section>

                <div class="e-modal-button-area">
                        <button @click="closeModal(true)">Cerrar</button>
                </div>
            </div>

        </div>
    `,
    props: ['data'],
    methods: {
        closeModal(action = null) {
            this.data.visible = false;
        }
    }
});

const app = new Vue({
    el: '#app',
    data: {
        name: '',
        dep: '',
        person: '',
        ip: '',
        horas:Int32Array = 0,
        showModal: false,
        modalVisible: false,
        modalConfig: {
            visible: false,
            title: "Confirmation",
            messageBody: '',
            info: ''
        }
    },
    methods:{
        crearVisita() {
            axios.get(`${RESOURCE_NAME}/${this.name}&${this.dep}&${this.person}&${this.ip}&${this.horas}&`)
            .then(response => this.modalConfig.info = response.data )
            this.openModal();
        },
        close() {
            this.$emit('close');
        },
        openModal() {
            this.modalConfig.visible = true;
        }
    }
});